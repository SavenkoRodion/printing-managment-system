import { Box, Button, Link, TextField } from "@mui/material";
import { useEffect, useState } from "react";

const Login = () => {
  const [lol, setLol] = useState("");
  useEffect(() => {
    console.log(
      fetch("https://localhost:7017/WeatherForecast").then((e) => {
        //console.log(e.body);
        console.log("lol");
        console.log(
          e.json().then((ee) => {
            console.log(ee);
          })
        );
      })
    );
  }, []);

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
        label="Password"
        type="password"
        variant="outlined"
        fullWidth
        size="small"
      />
      <Button variant="contained" color="primary" fullWidth type="submit">
        Login
      </Button>
      <Link>Password reset</Link>
    </Box>
  );
};

export default Login;
