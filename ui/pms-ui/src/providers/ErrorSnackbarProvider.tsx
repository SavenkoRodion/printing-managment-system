import React, { useState } from "react";
import { Snackbar, Alert } from "@mui/material";
import { ErrorSnackbarContext } from "../components/reusable/ErrorSnackbarContext";

export const ErrorSnackbarProvider: React.FC<{ children: React.ReactNode }> = ({
  children,
}) => {
  const [errorMessage, setErrorMessage] = useState<string | null>(null);
  const [isSuccess, setIsSuccess] = useState<boolean>(false);

  const showMessage = (message: string, isSuccess?: boolean) => {
    setErrorMessage(message);
    setIsSuccess(isSuccess ?? false);
  };

  const handleClose = () => {
    setErrorMessage(null);
  };

  return (
    <ErrorSnackbarContext.Provider value={{ showMessage }}>
      {children}
      <Snackbar
        open={!!errorMessage}
        autoHideDuration={60000}
        onClose={handleClose}
        anchorOrigin={{ vertical: "bottom", horizontal: "right" }}
      >
        <Alert
          onClose={handleClose}
          severity={isSuccess ? "success" : "error"}
          sx={{ width: "100%" }}
        >
          {errorMessage}
        </Alert>
      </Snackbar>
    </ErrorSnackbarContext.Provider>
  );
};
