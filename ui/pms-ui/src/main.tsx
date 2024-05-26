import React from "react";
import ReactDOM from "react-dom/client";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import LoginLayout from "./components/layouts/LoginLayout";
import Login from "./components/login/Login";
import PasswordReset from "./components/password/password";
import BaselineLayout from "./components/layouts/BaselineLayout";
import Editor from "./components/editor/Editor";


ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<BaselineLayout />}>
          <Route path="/" element={<LoginLayout />}>
            <Route index element={<Login />} />  
            <Route path="/password" element={<PasswordReset />} /> 
            <Route path="/login" element={<Login />} />  
            <Route path="/editor" element={<Editor />} /> 
          </Route>
        </Route>
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);
