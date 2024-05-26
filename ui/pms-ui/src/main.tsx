import React, { createContext } from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import LoginLayout from "./components/layouts/LoginLayout.tsx";
import Login from "./components/login/Login.tsx";
import PasswordReset from "./components/password/password";
import BaselineLayout from "./components/layouts/BaselineLayout.tsx";
import { Provider } from "react-redux";
import { store } from "./store/store.ts";

export const AuthContext = createContext("");

const getCookieValue = (name: string) =>
  document.cookie.match("(^|;)\\s*" + name + "\\s*=\\s*([^;]+)")?.pop() || "";

const lol = getCookieValue("auth");

console.log(lol);

ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <Provider store={store}>
      <AuthContext.Provider value={lol}>
        <BrowserRouter>
          <Routes>
            <Route path="/" element={<BaselineLayout />}>
              <Route path="/" element={<LoginLayout />}>
                <Route index element={<Login />} />
                <Route path="/password" element={<PasswordReset />} />
              </Route>
            </Route>
          </Routes>
        </BrowserRouter>
      </AuthContext.Provider>
    </Provider>
  </React.StrictMode>
);
