import {
  AppBar,
  Toolbar,
  Typography,
  Link,
  Box,
  IconButton,
  Menu,
  MenuItem,
  Divider,
} from "@mui/material";
import { AccountCircle } from "@mui/icons-material";
import { Outlet, Link as RouterLink } from "react-router-dom";
import { useState } from "react";

const AuthorizedMenuLayout = () => {
  const [anchorEl, setAnchorEl] = useState<null | HTMLElement>(null);
  const isMenuOpen = Boolean(anchorEl);

  const handleMenuToggle = (event: React.MouseEvent<HTMLElement>) => {
    setAnchorEl(isMenuOpen ? null : event.currentTarget);
  };

  const handleMenuClose = () => {
    setAnchorEl(null);
  };

  const userEmail = "user@example.com";
  const primary = {
    main: "#19247C",
  };

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
        sx={{ backgroundColor: primary, boxShadow: "none" }}
      >
        <Toolbar sx={{ justifyContent: "space-between", paddingX: "16px" }}>
          <Box sx={{ display: "flex", alignItems: "center", gap: 4 }}>
            <Typography variant="h6" component="div" sx={{ marginRight: 4 }}>
              <Link
                component={RouterLink}
                to="/"
                underline="none"
                color="inherit"
              >
                VeraPrint
              </Link>
            </Typography>

            <Link
              component={RouterLink}
              to="/klienci"
              underline="none"
              color="inherit"
            >
              Klienci
            </Link>
            <Link
              component={RouterLink}
              to="/produkty-konfiguracja"
              underline="none"
              color="inherit"
            >
              Produkty konfiguracja
            </Link>
            <Link
              component={RouterLink}
              to="/produkty-klientow"
              underline="none"
              color="inherit"
            >
              Produkty klientów
            </Link>
            <Link
              component={RouterLink}
              to="/zamowienia"
              underline="none"
              color="inherit"
            >
              Zamówienia
            </Link>
            <Link
              component={RouterLink}
              to="/faktury"
              underline="none"
              color="inherit"
            >
              Faktury
            </Link>
            <Link
              component={RouterLink}
              to="/ustawienia"
              underline="none"
              color="inherit"
            >
              Ustawienia
            </Link>
            <Link
              component={RouterLink}
              to="/pomoc"
              underline="none"
              color="inherit"
            >
              Pomoc
            </Link>
            <Link
              component={RouterLink}
              to="/users"
              underline="none"
              color="inherit"
            >
              Dashboard
            </Link>
          </Box>

          <Box sx={{ display: "flex", alignItems: "center", gap: 3 }}>
            <Typography variant="body1" color="inherit">
              {userEmail}
            </Typography>
            <IconButton
              edge="end"
              aria-label="konto użytkownika"
              aria-controls="menu-appbar"
              aria-haspopup="true"
              onClick={handleMenuToggle}
              color="inherit"
            >
              <AccountCircle />
            </IconButton>

            <Menu
              anchorEl={anchorEl}
              anchorOrigin={{ vertical: "bottom", horizontal: "right" }}
              keepMounted
              transformOrigin={{ vertical: "top", horizontal: "right" }}
              open={isMenuOpen}
              onClose={handleMenuClose}
              sx={{ mt: 2 }}
            >
              <MenuItem disabled>{userEmail}</MenuItem>
              <Divider />
              <MenuItem
                onClick={handleMenuClose}
                sx={{ fontWeight: "bold", color: "red" }}
              >
                Wyloguj
              </MenuItem>
            </Menu>
          </Box>
        </Toolbar>
      </AppBar>

      <Box sx={{ width: "100%", maxWidth: "1200px", paddingTop: "100px" }}>
        <Outlet />
      </Box>
    </Box>
  );
};
export default AuthorizedMenuLayout;
