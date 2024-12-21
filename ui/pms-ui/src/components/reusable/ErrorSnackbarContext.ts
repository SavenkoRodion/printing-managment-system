import { createContext } from "react";

interface ErrorSnackbarContextType {
  showError: (message: string, isSuccess?: boolean) => void;
}

export const ErrorSnackbarContext = createContext<
  ErrorSnackbarContextType | undefined
>(undefined);
