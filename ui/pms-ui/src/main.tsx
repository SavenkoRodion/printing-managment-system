import React from "react";
import ReactDOM from "react-dom/client";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import LoginLayout from "./components/layouts/LoginLayout.tsx";
import Login from "./components/login/Login.tsx";
import PasswordReset from "./components/password/password";
import BaselineLayout from "./components/layouts/BaselineLayout";
import Editor from "./components/editor/Editor";
import {
  AuthorizedExampleOneWrapped,
  AuthorizedExampleTwoWrapped,
} from "./authorizationWrappers/AuthorizedComponents.tsx";

ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<BaselineLayout />}>
          <Route path="/" element={<LoginLayout />}>
            <Route index element={<Login />} />
            <Route path="/password" element={<PasswordReset />} />
            <Route path="/login" element={<Login />} />
            <Route
              path="/authorized-example-one"
              element={<AuthorizedExampleOneWrapped />}
            />
            <Route
              path="/authorized-example-two"
              element={<AuthorizedExampleTwoWrapped />}
            />
            <Route path="/login" element={<Login />} />
            <Route path="/editor" element={<Editor />} />
          </Route>
        </Route>
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);
