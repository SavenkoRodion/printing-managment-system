/* eslint-disable @typescript-eslint/no-explicit-any */

// import { store } from "../store/store";

// enum HttpMethodEnum {
//   GET = "GET",
//   POST = "POST",
//   PUT = "PUT",
//   DELETE = "DELETE",
// }

// export const fetchWrapper = {
//   get: request(HttpMethodEnum.GET),
//   post: request(HttpMethodEnum.POST),
//   put: request(HttpMethodEnum.PUT),
//   delete: request(HttpMethodEnum.DELETE),
// };

// // type TAuthHeader = {
// //   Authorization?: string;
// // };

// // type THttpRequestOptions = {
// //   method: HttpMethodEnum;
// //   headers: TAuthHeader;
// // };

// function request(method: HttpMethodEnum) {
//   return (url: string, body: unknown) => {
//     const requestOptions: any = {
//       method,
//       headers: authHeader(url),
//     };
//     if (body) {
//       requestOptions.headers["Content-Type"] = "application/json";
//       requestOptions.body = JSON.stringify(body);
//     }
//     return fetch(url, requestOptions).then(handleResponse);
//   };
// }

// // helper functions

// function authHeader(url: string) {
//   // return auth header with jwt if user is logged in and request is to the api url
//   const token = authToken();
//   const isLoggedIn = !!token;
//   const isApiUrl = url.startsWith("http://localhost:4000");
//   if (isLoggedIn && isApiUrl) {
//     return { Authorization: `Bearer ${token}` };
//   } else {
//     return {};
//   }
// }

// function authToken() {
//   const storeState = store.getState();
//   return storeState.auth.admin?.Token;
// }

// function handleResponse(response: any) {
//   return response.text().then((text: any) => {
//     const data = text && JSON.parse(text);

//     if (!response.ok) {
//       if ([401, 403].includes(response.status) && authToken()) {
//         // auto logout if 401 Unauthorized or 403 Forbidden response returned from api
//         const logout = () => store.dispatch(authActions.logout());
//         logout();
//       }

//       const error = (data && data.message) || response.statusText;
//       return Promise.reject(error);
//     }

//     return data;
//   });
// }
