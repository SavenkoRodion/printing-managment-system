import React from "react";
import ReactDOM from "react-dom/client";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import LoginLayout from "./components/layouts/LoginLayout.tsx";
import Login from "./pages/login/Login.tsx";
import BaselineLayout from "./components/layouts/BaselineLayout";
import AuthorizedExampleOne from "./components/authorized-example/AuthorizedExampleOne.tsx";
import AuthorizedExampleTwo from "./components/authorized-example/AuthorizedExampleTwo.tsx";
import AuthorizedComponent from "./authorizationWrappers/AuthorizedComponent.tsx";
import Editor from "./pages/editor/Editor.tsx";
import PasswordReset from "./pages/password/Password.tsx";

ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<BaselineLayout />}>
          <Route path="/" element={<LoginLayout />}>
            <Route element={<AuthorizedComponent />}>
              <Route path="/login" element={<Login />} />
              <Route
                path="/authorized-example-one"
                element={<AuthorizedExampleOne />}
              />
              <Route
                path="/authorized-example-two"
                element={<AuthorizedExampleTwo />}
              />
              <Route path="/editor" element={<Editor />} />
            </Route>
            <Route>
              <Route index element={<Login />} />
              <Route path="/password" element={<PasswordReset />} />
            </Route>
          </Route>
        </Route>
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);
