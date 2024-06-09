import { Box, Button, Typography } from "@mui/material";
import React from "react";

const AuthorizedExampleOne = () => {
  const handleSubmit = (e: React.MouseEvent<HTMLElement>) => {
    e.preventDefault();
    fetch("https://localhost:7017/api/auth/who-am-i", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
      credentials: "include",
    }).then(() => console.log(document.cookie));
  };
  return (
    <Box>
      <Typography component={"h1"}>JESTEŚ ZALOGOWANY!</Typography>
      <Button variant="contained" color="primary" onClick={handleSubmit}>
        Cokolwiek
      </Button>
    </Box>
  );
};

export default AuthorizedExampleOne;
