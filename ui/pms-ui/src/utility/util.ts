export const isStatusCodeSuccessfull = (statusCode: number) => {
  return statusCode >= 200 && statusCode <= 299;
};
