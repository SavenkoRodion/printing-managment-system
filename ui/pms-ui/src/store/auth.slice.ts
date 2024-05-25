import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import ApiAdmin from "../model/contract/ApiAdmin";
import TCredentials from "../model/TCredentials";
import { fetchWrapper } from "../util/fetch-wrapper";

type AuthState = {
  admin: ApiAdmin | null;
};

const initialState: AuthState = {
  admin: JSON.parse(localStorage.getItem("admin") ?? "{}"),
};

const createReducers = () => {
  const logout = (state: AuthState) => {
    state.admin = null;
    localStorage.removeItem("admin");
  };
  return { logout };
};

const createExtraActions = () => {
  const baseUrl = `http://localhost:4000/users`;

  const login = () => {
    return createAsyncThunk(
      `auth/login`,
      async ({ username, password }: TCredentials) =>
        await fetchWrapper.post(`${baseUrl}/authenticate`, {
          username,
          password,
        })
    );
  };

  return {
    login: login(),
  };
};

function createExtraReducers() {
  return {
    ...login(),
  };

  function login() {
    var { pending, fulfilled, rejected } = extraActions.login;
    return {
      [pending]: (state) => {
        state.error = null;
      },
      [fulfilled]: (state, action) => {
        const user = action.payload;

        // store user details and jwt token in local storage to keep user logged in between page refreshes
        localStorage.setItem("user", JSON.stringify(user));
        state.user = user;

        // get return url from location state or default to home page
        const { from } = history.location.state || { from: { pathname: "/" } };
        history.navigate(from);
      },
      [rejected]: (state, action) => {
        state.error = action.error;
      },
    };
  }
}

const authSlice = createSlice({
  name: "auth",
  initialState,
  reducers: createReducers(),
  extraReducers: createExtraReducers,
});

export default authSlice.reducer;
