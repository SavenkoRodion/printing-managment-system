import { Box, Button, TextField } from "@mui/material";

const PasswordReset = () => {
  return (
    <Box
      component="form"
      sx={{
        minWidth: "500px",
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
