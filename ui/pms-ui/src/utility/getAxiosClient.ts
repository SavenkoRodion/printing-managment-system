import axios from "axios";

const getAxiosClient = () =>
  axios.create({
    baseURL: "https://localhost:7017/api",
    withCredentials: true,
  });

export default getAxiosClient;
