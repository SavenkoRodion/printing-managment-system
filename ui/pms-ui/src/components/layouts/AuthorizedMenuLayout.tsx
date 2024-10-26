import { AppBar, Toolbar, Typography, Button, Box } from "@mui/material";
import { Outlet } from "react-router-dom";
const AuthorizedMenuLayout = () => {
  return (
    <Box
      sx={{
        display: "flex",
        justifyContent: "center",
        fontFamily: "'Open Sans', sans-serif",
      }}
    >
      <AppBar
        position="fixed"
        sx={{ backgroundColor: "#1976d2", boxShadow: "none" }}
      >
        <Toolbar>
          <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
            VeraPrint
          </Typography>
          <Button color="inherit" sx={{ textTransform: "none" }}>
            Klienci
          </Button>
          <Button color="inherit" sx={{ textTransform: "none" }}>
            Produkty konfiguracja
          </Button>
          <Button
            href="/produkty"
            color="inherit"
            sx={{ textTransform: "none" }}
          >
            Produkty klientów
          </Button>
          <Button color="inherit" sx={{ textTransform: "none" }}>
            Zamówienia
          </Button>
          <Button color="inherit" sx={{ textTransform: "none" }}>
            Faktury
          </Button>
          <Button color="inherit" sx={{ textTransform: "none" }}>
            Ustawienia
          </Button>
          <Button color="inherit" sx={{ textTransform: "none" }}>
            Pomoc
          </Button>
          <Button color="inherit" sx={{ textTransform: "none" }}>
            Dashboard
          </Button>
        </Toolbar>
      </AppBar>
      <Box sx={{ paddingTop: "100px" }}>
        <Outlet />
      </Box>
    </Box>
  );
};
export default AuthorizedMenuLayout;
