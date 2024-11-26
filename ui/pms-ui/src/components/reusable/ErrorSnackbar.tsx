import React, { createContext, useContext, useState } from "react";
import { Snackbar, Alert } from "@mui/material";

interface ErrorSnackbarContextType {
  showError: (message: string) => void;
}

const ErrorSnackbarContext = createContext<
  ErrorSnackbarContextType | undefined
>(undefined);

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

// eslint-disable-next-line react-refresh/only-export-components
export const useErrorSnackbar = (): ErrorSnackbarContextType => {
  const context = useContext(ErrorSnackbarContext);
  if (!context) {
    throw new Error();
  }
  return context;
};
