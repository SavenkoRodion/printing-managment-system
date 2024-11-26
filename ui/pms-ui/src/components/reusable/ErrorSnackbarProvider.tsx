import React, { useState } from "react";
import { Snackbar, Alert } from "@mui/material";
import { ErrorSnackbarContext } from "./ErrorSnackbarContext";

export const ErrorSnackbarProvider: React.FC<{ children: React.ReactNode }> = ({
  children,
}) => {
  const [errorMessage, setErrorMessage] = useState<string | null>(null);

  const showError = (message: string) => {
    setErrorMessage(message);
  };

  const handleClose = () => {
    setErrorMessage(null);
  };

  return (
    <ErrorSnackbarContext.Provider value={{ showError }}>
      {children}
      <Snackbar
        open={!!errorMessage}
        autoHideDuration={60000}
        onClose={handleClose}
        anchorOrigin={{ vertical: "bottom", horizontal: "right" }}
      >
        <Alert onClose={handleClose} severity="error" sx={{ width: "100%" }}>
          {errorMessage}
        </Alert>
      </Snackbar>
    </ErrorSnackbarContext.Provider>
  );
};
