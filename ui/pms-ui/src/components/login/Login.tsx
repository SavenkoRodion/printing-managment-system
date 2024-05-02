import { Box, Button, Link, TextField } from "@mui/material";
import { useEffect } from "react";
import { Link as RouterLink } from "react-router-dom";

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
      <Link component={RouterLink} to="/password">Nie pamiętam hasła</Link>
    </Box>
  );
};

export default Login;
