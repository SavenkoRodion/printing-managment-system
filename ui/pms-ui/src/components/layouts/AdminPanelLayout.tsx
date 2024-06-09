import { AppBar, Box, Button, Toolbar, Typography } from "@mui/material";
import { Outlet } from "react-router-dom";

const AdminPanelLayout = () => {
  return (
    <Box>
      <AppBar position="static" sx={{ width: "100%" }}>
        <Toolbar>
          <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
            News
          </Typography>
          <Button color="inherit">Login</Button>
        </Toolbar>
      </AppBar>
      <Outlet />
    </Box>
  );
};

export default AdminPanelLayout;
