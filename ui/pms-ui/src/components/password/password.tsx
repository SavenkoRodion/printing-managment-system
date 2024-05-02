import { Box, Button, TextField } from "@mui/material";
import { useEffect } from "react";

const PasswordReset = () => {
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
      <TextField
        label="Wprowadź E-Mail Twojego konta"
        variant="outlined"
        fullWidth
        size="small"
      />
      <Button variant="contained" color="primary" fullWidth type="submit">
        Wyślij
      </Button>
    </Box>
  );
};
export default PasswordReset;
