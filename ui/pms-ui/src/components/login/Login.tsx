import { Box, Button, Link, TextField } from "@mui/material";

const Login = () => {
  return (
    <Box
      component="form"
      sx={{
        maxWidth: "500px",
        "& .MuiTextField-root": {
          mb: 2,
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
