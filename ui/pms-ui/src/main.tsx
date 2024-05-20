import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import LoginLayout from "./components/layouts/LoginLayout.tsx";
import Login from "./components/login/Login.tsx";
import PasswordReset from "./components/password/password";
import BaselineLayout from "./components/layouts/BaselineLayout.tsx";
import { Provider } from "react-redux";
import { store } from "./store/index.js";

ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <Provider store={store}>
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
    </Provider>
  </React.StrictMode>
);
