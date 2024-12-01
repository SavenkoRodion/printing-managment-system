import { createContext } from "react";

interface ErrorSnackbarContextType {
  showError: (message: string) => void;
}

export const ErrorSnackbarContext = createContext<
  ErrorSnackbarContextType | undefined
>(undefined);
