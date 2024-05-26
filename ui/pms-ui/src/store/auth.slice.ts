import { PayloadAction, createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import ApiAdmin from "../model/contract/ApiAdmin";
import TCredentials from "../model/TCredentials";

type AuthState = {
  admin: ApiAdmin | null;
};

const initialState: AuthState = {
  admin: JSON.parse(localStorage.getItem("admin") ?? "{}"),
};

const baseUrl = `https://localhost:4000/Admin`;

const loginAction = createAsyncThunk(
  `auth/login`,
  async ({ username, password }: TCredentials) => {
    await fetch(`${baseUrl}/authenticate`, {
      method: "POST",
      body: JSON.stringify({ username, password }),
    });
  }
);

function login() {
  const { pending, fulfilled, rejected } = createExtraActions().login;
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

const authSlice = createSlice({
  name: "auth",
  initialState,
  reducers: {
    logout: (state: AuthState) => {
      state.admin = null;
      localStorage.removeItem("admin");
    },
  },
  extraReducers: (builder) => {
    builder.addCase(
      loginAction.fulfilled,
      (state, action: PayloadAction<number>) => {
        const user = action.payload;

        // store user details and jwt token in local storage to keep user logged in between page refreshes
        localStorage.setItem("user", JSON.stringify(user));
        state.admin = user;

        // get return url from location state or default to home page
        const { from } = history.location.state || { from: { pathname: "/" } };
        history.navigate(from);
      }
    );
  },
});

export const { logout } = authSlice.actions;

export default authSlice.reducer;
