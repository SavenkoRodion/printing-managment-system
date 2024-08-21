import React from "react";
import ReactDOM from "react-dom/client";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import LoginLayout from "./components/layouts/LoginLayout.tsx";
import Login from "./components/login/Login.tsx";
import PasswordReset from "./components/password/password";
import BaselineLayout from "./components/layouts/BaselineLayout";
import Editor from "./components/editor/Editor";
import AuthorizedExampleOne from "./components/authorized-example/AuthorizedExampleOne.tsx";
import AuthorizedExampleTwo from "./components/authorized-example/AuthorizedExampleTwo.tsx";
import AuthorizedComponent from "./authorizationWrappers/AuthorizedComponent.tsx";
import Product from "./components/products/Products.tsx";

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
              <Route path="/produkty" element={<Product />} />
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
