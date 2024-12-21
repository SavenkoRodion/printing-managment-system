import { createContext } from "react";

interface ErrorSnackbarContextType {
  showMessage: (message: string, isSuccess?: boolean) => void;
}

export const ErrorSnackbarContext = createContext<
  ErrorSnackbarContextType | undefined
>(undefined);
