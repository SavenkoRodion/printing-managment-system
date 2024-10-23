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
import AuthorizedMenu from "./components/layouts/AuthorizedMenuLayout.tsx";
import ProductPage from "./components/products/Products.tsx";
import ProjectList from "./components/products/ProjectList.tsx";

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
        <Route element={<AuthorizedComponent />}>
          <Route path="/produkty" element={<ProductPage />} />
        </Route>
        <Route element={<AuthorizedMenu />}>
          <Route path="/projects" element={<ProjectList />} />
        </Route>
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);
