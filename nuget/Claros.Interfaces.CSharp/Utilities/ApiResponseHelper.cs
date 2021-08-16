using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using Claros.Common.Core;
using Claros.Interfaces.CSharp.Core;

namespace Claros.Interfaces.CSharp.Utilities
{
    /// <summary>
    /// Helpers for <see cref="ApiResponse"/>.
    /// </summary>
    [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
    public static class ApiResponseHelper
    {
        #region Type handlers

        /// <summary>
        /// Populates an <see cref="ApiResponse"/> with content. Matches the content type and assigns the content to the
        /// appropriate property of the <see cref="ClarosContent"/>.
        /// Throws an exception if the content type cannot be assigned.
        /// </summary>
        /// <typeparam name="T">Type of content.</typeparam>
        /// <param name="apiResponse">The ApiResponse object to assign the content to.</param>
        /// <param name="content">The content to assign.</param>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        private static void GenericTypeHandler<T>(ApiResponse apiResponse, T content)
        {
            var contentType = content.GetType();

            if (apiResponse.Content == null)
                apiResponse.Content = new ClarosContent();

            var clarosContent = apiResponse.Content;
            var clarosContentProperties = clarosContent.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            var matchingProperty = clarosContentProperties.FirstOrDefault(x => x.PropertyType == contentType);
            if (matchingProperty != null)
            {
                // ClarosContent property is not a wrapper around a list or dictionary, just assign the content.
                matchingProperty.SetValue(clarosContent, content);
                return;
            }

            // Check if ClarosContent property is a wrapper around a list or dictionary by checking for
            // a property that contains a list or dictionary of 'content'.
            foreach (var property in clarosContentProperties) // Iterate properties of ClarosContent
            {
                foreach (var propertyInfo in property.PropertyType.GetProperties(BindingFlags.Instance | BindingFlags.Public)) // Iterate properties of 'p'
                {
                    // Check if property is a dictionary.
                    if (propertyInfo.PropertyType.GetInterface("IDictionary") != null)
                    {
                        var args = propertyInfo.PropertyType.GetGenericArguments();

                        // Check if the dictionary type matches 'content'.
                        if (!args.Except(contentType.GenericTypeArguments).Any())
                        {
                            // Create instance of property that wraps the dictionary.
                            var wrapperProperty = Activator.CreateInstance(property.PropertyType);

                            if (propertyInfo.GetValue(wrapperProperty) is IDictionary dictionary)
                            {
                                // Add content to dictionary.
                                var kvProps = contentType.GetProperties();
                                dictionary.Add(kvProps[0].GetValue(content), kvProps[1].GetValue(content));

                                // Assign the wrapperProperty to clarosContent.
                                property.SetValue(clarosContent, wrapperProperty);

                                return;
                            }
                        }
                        // Can I access the add property?
                        var addMethod = propertyInfo.PropertyType.GetMethod("Add", args);
                        if (addMethod != null && content is DictionaryEntry entryContent)
                        {
                            // double check the runtime type of entryContent and the args of the method.
                            if (args.Except(new[] { entryContent.Key.GetType(), entryContent.Value.GetType() }).Any())
                                continue;

                            var wrapperProperty = Activator.CreateInstance(property.PropertyType);
                            property.SetValue(clarosContent, wrapperProperty);
                            var itemsProperty = propertyInfo.GetValue(wrapperProperty);
                            addMethod.Invoke(itemsProperty, new[] { entryContent.Key, entryContent.Value });
                            return;
                        }

                        continue;
                    }

                    // Check if the property is a list of 'content'.
                    if (propertyInfo.PropertyType.GetGenericArguments().Any(x => x == contentType))
                    {
                        // Create instance of property that wraps the list.
                        var wrapperProperty = Activator.CreateInstance(property.PropertyType);
                        if (propertyInfo.GetValue(wrapperProperty) is IList list)
                        {
                            list.Add(content);

                            // Assign the wrapperProperty to clarosContent.
                            property.SetValue(clarosContent, wrapperProperty);

                            return;
                        }
                    }
                }
            }

            throw new ArgumentException($"ApiResponseHelper could not process type: {contentType.FullName}");
        }

        #endregion Type handlers

        #region GetFacadeApiResponse

        /// <summary>
        /// Generates a response for the api facade to return to the api controller that contains
        /// only an HTTP status code, no content or errors.
        /// </summary>
        /// <param name="httpStatusCode">HTTP status code to be returned to the client.</param>
        /// <returns><see cref="FacadeApiResponse"/> that contains an HTTP status code.</returns>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static FacadeApiResponse GetFacadeApiResponse(HttpStatusCode httpStatusCode)
        {
            return new FacadeApiResponse { StatusCode = (int)httpStatusCode, ApiResponse = new ApiResponse() };
        }

        /// <summary>
        /// Generates a response for the api facade to return to the api controller that contains
        /// an HTTP status code and an error, no content.
        /// </summary>
        /// <param name="httpStatusCode">HTTP status code to be returned to the client.</param>
        /// <param name="error">Error to include in the response.</param>
        /// <returns><see cref="FacadeApiResponse"/> that contains an HTTP status code and an error.</returns>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static FacadeApiResponse GetFacadeApiResponse(HttpStatusCode httpStatusCode, IErrorCode error)
        {
            return GetFacadeApiResponse(httpStatusCode, new[] { error });
        }

        /// <summary>
        /// Generates a response for the api facade to return to the api controller that contains
        /// an HTTP status code and an error, no content.
        /// </summary>
        /// <param name="httpStatusCode">HTTP status code to be returned to the client.</param>
        /// <param name="error">Error to include in the response.</param>
        /// <returns><see cref="FacadeApiResponse"/> that contains an HTTP status code and an error.</returns>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static FacadeApiResponse GetFacadeApiResponse(HttpStatusCode httpStatusCode, ApiError error)
        {
            return GetFacadeApiResponse(httpStatusCode, new[] { error });
        }

        /// <summary>
        /// Generates a response for the api facade to return to the api controller that contains
        /// an HTTP status code and a errors, no content.
        /// </summary>
        /// <param name="httpStatusCode">HTTP status code to be returned to the client.</param>
        /// <param name="errors">Error to include in the response.</param>
        /// <returns><see cref="FacadeApiResponse"/> that contains an HTTP status code and errors.</returns>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static FacadeApiResponse GetFacadeApiResponse(HttpStatusCode httpStatusCode, IEnumerable<IErrorCode> errors)
        {
            var result = new FacadeApiResponse { StatusCode = (int)httpStatusCode, ApiResponse = new ApiResponse() };
            AddErrorsToResponse(result.ApiResponse, errors);

            return result;
        }

        /// <summary>
        /// Generates a response for the api facade to return to the api controller that contains
        /// an HTTP status code and a errors, no content.
        /// </summary>
        /// <param name="httpStatusCode">HTTP status code to be returned to the client.</param>
        /// <param name="errors">Error to include in the response.</param>
        /// <returns><see cref="FacadeApiResponse"/> that contains an HTTP status code and errors.</returns>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static FacadeApiResponse GetFacadeApiResponse(HttpStatusCode httpStatusCode, IEnumerable<ApiError> errors)
        {
            var result = new FacadeApiResponse { StatusCode = (int)httpStatusCode, ApiResponse = new ApiResponse() };
            AddErrorsToResponse(result.ApiResponse, errors);

            return result;
        }

        /// <summary>
        /// Generates a response for the api facade to return to the api controller that contains
        /// an HTTP status code and content, no errors.
        /// </summary>
        /// <typeparam name="T">Type of content.</typeparam>
        /// <param name="httpStatusCode">HTTP status code to be returned to the client.</param>
        /// <param name="content">Content to include in the response.</param>
        /// <returns><see cref="FacadeApiResponse"/> that contains an HTTP status code and content.</returns>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static FacadeApiResponse GetFacadeApiResponse<T>(T content, HttpStatusCode httpStatusCode)
        {
            var result = new FacadeApiResponse { StatusCode = (int)httpStatusCode, ApiResponse = new ApiResponse() };

            if (content != null)
                AddContentToResponse(result.ApiResponse, content);

            return result;
        }

        /// <summary>
        /// Generates a response for the api facade to return to the api controller that contains
        /// an HTTP status code and optional content and error.
        /// </summary>
        /// <typeparam name="T">Type of content.</typeparam>
        /// <param name="httpStatusCode">HTTP status code to be returned to the client.</param>
        /// <param name="error">Error to include in the response.</param>
        /// <param name="content">Content to include in the response.</param>
        /// <returns><see cref="FacadeApiResponse"/>.</returns>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static FacadeApiResponse GetFacadeApiResponse<T>(T content, HttpStatusCode httpStatusCode, IErrorCode error)
        {
            return GetFacadeApiResponse(content, httpStatusCode, error != null ? new[] { error } : null);
        }

        /// <summary>
        /// Generates a response for the api facade to return to the api controller that contains
        /// an HTTP status code and optional content and error.
        /// </summary>
        /// <typeparam name="T">Type of content.</typeparam>
        /// <param name="httpStatusCode">HTTP status code to be returned to the client.</param>
        /// <param name="error">Error to include in the response.</param>
        /// <param name="content">Content to include in the response.</param>
        /// <returns><see cref="FacadeApiResponse"/>.</returns>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static FacadeApiResponse GetFacadeApiResponse<T>(T content, HttpStatusCode httpStatusCode, ApiError error)
        {
            return GetFacadeApiResponse(content, httpStatusCode, error != null ? new[] { error } : null);
        }

        /// <summary>
        /// Generates a response for the api facade to return to the api controller that contains
        /// an HTTP status code and optional content and errors.
        /// </summary>
        /// <typeparam name="T">Type of content.</typeparam>
        /// <param name="httpStatusCode">HTTP status code to be returned to the client.</param>
        /// <param name="content">Content to include in the response.</param>
        /// <param name="errors">Errors to include in the response.</param>
        /// <returns><see cref="FacadeApiResponse"/>.</returns>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static FacadeApiResponse GetFacadeApiResponse<T>(T content, HttpStatusCode httpStatusCode, IEnumerable<IErrorCode> errors)
        {
            var result = new FacadeApiResponse { StatusCode = (int)httpStatusCode, ApiResponse = new ApiResponse() };

            if (content != null)
                AddContentToResponse(result.ApiResponse, content);

            if (errors != null)
                AddErrorsToResponse(result.ApiResponse, errors);

            return result;
        }

        /// <summary>
        /// Generates a response for the api facade to return to the api controller that contains
        /// an HTTP status code and optional content and errors.
        /// </summary>
        /// <typeparam name="T">Type of content.</typeparam>
        /// <param name="httpStatusCode">HTTP status code to be returned to the client.</param>
        /// <param name="content">Content to include in the response.</param>
        /// <param name="errors">Errors to include in the response.</param>
        /// <returns><see cref="FacadeApiResponse"/>.</returns>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static FacadeApiResponse GetFacadeApiResponse<T>(T content, HttpStatusCode httpStatusCode, IEnumerable<ApiError> errors)
        {
            var result = new FacadeApiResponse { StatusCode = (int)httpStatusCode, ApiResponse = new ApiResponse() };

            if (content != null)
                AddContentToResponse(result.ApiResponse, content);

            if (errors != null)
                AddErrorsToResponse(result.ApiResponse, errors);

            return result;
        }

        #endregion GetFacadeApiResponse

        #region Private Helpers

        /// <summary>
        /// Adds the content to an <see cref="ApiResponse"/>.
        /// </summary>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        private static void AddContentToResponse<T>(ApiResponse apiResponse, T content)
        {
            GenericTypeHandler(apiResponse, content);
        }

        /// <summary>
        /// Adds an error to an <see cref="ApiResponse"/>.
        /// </summary>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static void AddErrorToResponse(ApiResponse apiResponse, IErrorCode error)
        {
            apiResponse.Errors.Add(new ApiError { StatusCode = (uint)error.StatusCode, Code = error.Code, Detail = error.ErrorDetail });
        }

        /// <summary>
        /// Adds errors to an <see cref="ApiResponse"/>.
        /// </summary>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public static void AddErrorsToResponse(ApiResponse apiResponse, IEnumerable<IErrorCode> errors)
        {
            foreach (var error in errors)
                apiResponse.Errors.Add(new ApiError { StatusCode = (uint)error.StatusCode, Code = error.Code, Detail = error.ErrorDetail });
        }

        /// <summary>
        /// Adds errors to an <see cref="ApiResponse"/>.
        /// </summary>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        private static void AddErrorsToResponse(ApiResponse apiResponse, IEnumerable<ApiError> errors)
        {
            apiResponse.Errors.AddRange(errors);
        }

        #endregion Private Helpers
    }

    /// <summary>
    /// Api facade response to be returned to the api controller.
    /// </summary>
    [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
    public class FacadeApiResponse
    {
        /// <summary>
        /// Http status code.
        /// </summary>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Content.
        /// </summary>
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
        public ApiResponse ApiResponse { get; set; }
    }
}
