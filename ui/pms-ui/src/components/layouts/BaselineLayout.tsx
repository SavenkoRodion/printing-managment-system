import { Box, CssBaseline } from "@mui/material";
import { Outlet } from "react-router-dom";

const BaselineLayout = () => {
  return (
    <Box>
      <CssBaseline />
      <>
        <Outlet />
      </>
    </Box>
  );
};

export default BaselineLayout;
