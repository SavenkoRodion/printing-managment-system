import { Box, Button, Link, Stack, TextField } from "@mui/material";

const Login = () => {
  return (
    <>
      <Box>
        <Stack>
          Login: <TextField variant="outlined" />
        </Stack>
      </Box>
      <Box>
        <Stack>
          Hasło: <TextField variant="outlined" />
        </Stack>
      </Box>
      <Box>
        <Link>Nie pamiętam hasła</Link>
        <Button variant="outlined">Zaloguj</Button>
      </Box>
    </>
  );
};

export default Login;
