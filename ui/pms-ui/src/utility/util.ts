import Client from "../model/Client";

export const isStatusCodeSuccessfull = (statusCode: number) => {
  return statusCode >= 200 && statusCode <= 299;
};

export const sortClientsByName = (clients: Client[]) => {
  return clients.sort((a: Client, b: Client) => a.name.localeCompare(b.name));
};
