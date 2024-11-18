import { Box, Button, Link, TextField, Alert } from "@mui/material";
import React, { useState } from "react";
import { useNavigate } from "react-router-dom";

const Login = () => {
  const navigate = useNavigate();
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState<string | null>(null);
  const [errorType, setErrorType] = useState<
    "auth" | "server" | "connection" | null
  >(null);

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();

    try {
      const response = await fetch("https://localhost:7017/api/auth/login", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          Email: username,
          Password: password,
        }),
        credentials: "include",
      });

      if (response.status === 400) {
        setError("Błędny login lub hasło");
        setErrorType("auth");
      } else if (!response.ok) {
        setError("Błąd serwera. Spróbuj ponownie później.");
        setErrorType("server");
      } else {
        navigate("/users");
      }
    } catch (error) {
      setError("Błąd połączenia z serwerem.");
      setErrorType("connection");
    }
  };

  return (
    <Box
      component="form"
      onSubmit={handleSubmit}
      sx={{
        maxWidth: "500px",
        "& .MuiTextField-root": {
          marginBottom: 2,
        },
      }}
    >
      {error && (
        <Alert
          severity={errorType === "auth" ? "warning" : "error"}
          sx={{
            mb: 2,
            height: "44px",
            display: "flex",
            alignItems: "center",
            justifyContent: "center",
          }}
        >
          {error}
        </Alert>
      )}
      <TextField
        label="Login"
        variant="outlined"
        fullWidth
        size="small"
        value={username}
        onChange={(e) => setUsername(e.target.value)}
        autoComplete="username"
      />
      <TextField
        label="Hasło"
        type="password"
        variant="outlined"
        fullWidth
        size="small"
        value={password}
        onChange={(e) => setPassword(e.target.value)}
        autoComplete="current-password"
      />

      <Button variant="contained" color="primary" fullWidth type="submit">
        Zaloguj
      </Button>
      <Link href="/password">Nie pamiętam hasła</Link>
    </Box>
  );
};

export default Login;
