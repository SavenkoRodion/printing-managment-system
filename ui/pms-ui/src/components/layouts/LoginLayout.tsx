import { Box, Typography } from "@mui/material";
import { Outlet } from "react-router-dom";

const LoginLayout = () => {
  return (
    <Box
      sx={{
        padding: "45px 15px 0",
        display: "flex",
        justifyContent: "center",
        justifyItems: "center",
        flexDirection: "column",
      }}
    >
      <Typography variant="h3" sx={{ fontSize: "24px", margin: "0 auto" }}>
        SYSTEM ZAMAWIANIA DRUKÓW FIRMOWYCH
      </Typography>
      <Typography variant="h3" sx={{ fontSize: "24px", margin: "0 auto" }}>
        PANEL LOGOWANIA ADMINISTRATORA
      </Typography>
      <Box
        component="img"
        sx={{
          height: 84,
          width: 92,
        }}
        alt="logo"
        src="../../../public/assets/images/splash.png"
      />
      <Box>
        <Outlet />
      </Box>
    </Box>
  );
};

export default LoginLayout;
