import { Box, Button, Link, TextField } from "@mui/material";
import axios from "axios";
import { useEffect } from "react";

const Login = () => {
  useEffect(() => {
    fetch("https://localhost:7017/WeatherForecast").then((response) => {
      response.json().then((data) => {
        console.log(data);
      });
    });
    axios
      .post("https://localhost:7017/auth/login", {
        email: "savenko340@gmail.com",
        password: "test",
      })
      .then(function () {
        const getCookieValue = (name: string) =>
          document.cookie
            .match("(^|;)\\s*" + name + "\\s*=\\s*([^;]+)")
            ?.pop() || "";

        const lol = getCookieValue("auth");

        console.log(lol);
        fetch("https://localhost:7017/auth/who-am-i", {
          method: "GET",
          headers: {
            "Content-Type": "application/json",
          },
          credentials: "include",
        }).then((response) => {
          response.json().then((data) => {
            console.log(data);
          });
        });
        fetch("https://localhost:7017/auth/").then((response) => {
          response.json().then((data) => {
            console.log(data);
          });
        });
      })
      .catch(function (error) {
        console.log(error);
      });
  }, []);

  // const lol = () => {

  // };

  return (
    <Box
      component="form"
      sx={{
        maxWidth: "500px",
        "& .MuiTextField-root": {
          marginBottom: 2,
        },
      }}
    >
      <TextField label="Login" variant="outlined" fullWidth size="small" />
      <TextField
        label="Hasło"
        type="password"
        variant="outlined"
        fullWidth
        size="small"
      />
      <Button variant="contained" color="primary" fullWidth type="submit">
        Zaloguj
      </Button>
      <Link href="/password">Nie pamiętam hasła</Link>
    </Box>
  );
};

export default Login;
