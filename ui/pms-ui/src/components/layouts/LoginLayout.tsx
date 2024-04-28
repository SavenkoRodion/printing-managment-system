import { Box, Typography } from "@mui/material";
import { Outlet } from "react-router-dom";
import styles from "./LoginLayout.style";

const LoginLayout = () => {
  return (
    <Box>
      <Box sx={styles.wrapper}>
        <Typography variant="h3" sx={styles.headerTextLine1}>
          SYSTEM ZAMAWIANIA DRUKÓW FIRMOWYCH
        </Typography>
        <Typography variant="h3" sx={styles.headerTextLine2}>
          PANEL LOGOWANIA ADMINISTRATORA
        </Typography>
        <Box
          component="img"
          sx={styles.loginImage}
          alt="logo"
          src="/assets/images/splash.png"
        />
      </Box>
      <Box
        sx={{
          display: "flex",
          justifyContent: "center",
        }}
      >
        <Outlet />
      </Box>
    </Box>
  );
};

export default LoginLayout;
