import { useContext } from "react";
import { ErrorSnackbarContext } from "./ErrorSnackbarContext";

export const useErrorSnackbar = () => {
  const context = useContext(ErrorSnackbarContext);
  if (!context) {
    throw new Error();
  }
  return context;
};
