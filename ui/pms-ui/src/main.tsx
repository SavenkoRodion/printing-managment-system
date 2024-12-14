import React from "react";
import ReactDOM from "react-dom/client";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import LoginLayout from "./components/layouts/LoginLayout.tsx";
import Login from "./components/login/Login.tsx";
import BaselineLayout from "./components/layouts/BaselineLayout";
import Editor from "./components/editor/Editor";
import AuthorizedComponent from "./authorizationWrappers/AuthorizedComponent.tsx";
import AuthorizedMenu from "./components/layouts/AuthorizedMenuLayout.tsx";
import ProductPage from "./components/products/Products.tsx";
import ProjectList from "./components/projects/ProjectList.tsx";
import Params from "./components/params/Params.tsx";
import Users from "./components/users/Users.tsx";
import ClientPage from "./components/clients/Clients.tsx";
import { ErrorSnackbarProvider } from "./providers/ErrorSnackbarProvider.tsx";

ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <ErrorSnackbarProvider>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<BaselineLayout />}>
            <Route path="/" element={<LoginLayout />}>
              <Route element={<AuthorizedComponent />}>
                <Route path="/login" element={<Login />} />
              </Route>

              <Route>
                <Route index element={<Login />} />
              </Route>
            </Route>
          </Route>
          <Route element={<AuthorizedComponent />}>
            <Route element={<AuthorizedMenu />}>
              <Route path="/projekty-klientow" element={<ProjectList />} />
              <Route path="/edytor/:type/:projectId" element={<Editor />} />
              <Route path="/produkty" element={<ProductPage />} />
              <Route path="/klienci" element={<ClientPage />} />
              <Route path="/parametry" element={<Params />} />
              <Route path="/users" element={<Users />} />
            </Route>
          </Route>
        </Routes>
      </BrowserRouter>
    </ErrorSnackbarProvider>
  </React.StrictMode>
);
