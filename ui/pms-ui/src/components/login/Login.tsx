import { Box, Button, Link, TextField } from "@mui/material";
import { useEffect } from "react";

const Login = () => {
  useEffect(() => {
    console.log(
      fetch("https://localhost:7017/WeatherForecast").then((response) => {
        response.json().then((data) => {
          console.log(data);
        });
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
        label="Hasło"
        type="password"
        variant="outlined"
        fullWidth
        size="small"
      />
      <Button variant="contained" color="primary" fullWidth type="submit">
        Zaloguj
      </Button>
      <Link>Nie pamiętam hasła</Link>
    </Box>
  );
};

export default Login;
