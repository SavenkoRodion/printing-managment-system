import { Box, CssBaseline } from "@mui/material";
import { Outlet } from "react-router-dom";

const BaselineLayout = () => {
  return (
    <Box
      sx={{
        display: "flex",
        justifyContent: "center",
        fontFamily: "'Open Sans', sans-serif",
      }}
    >
      <CssBaseline />
      <>
        <Outlet />
      </>
    </Box>
  );
};

export default BaselineLayout;
