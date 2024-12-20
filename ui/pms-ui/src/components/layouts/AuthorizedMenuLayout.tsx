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
import { Outlet, Link as RouterLink, useNavigate } from "react-router-dom";
import { useState, useEffect } from "react";
import getAxiosClient from "../../utility/getAxiosClient";
import styles from "./AuthorizedMenuLayout.style";

const AuthorizedMenuLayout = () => {
  const [anchorEl, setAnchorEl] = useState<null | HTMLElement>(null);
  const isMenuOpen = Boolean(anchorEl);
  const [userEmail, setUserEmail] = useState<string | null>(null);
  const navigate = useNavigate();

  const handleMenuToggle = (event: React.MouseEvent<HTMLElement>) => {
    setAnchorEl(isMenuOpen ? null : event.currentTarget);
  };

  const handleMenuClose = () => {
    setAnchorEl(null);
  };
  useEffect(() => {
    const email = getAxiosClient();

    email.get("/auth/who-am-i").then((response) => {
      setUserEmail(response.data.email);
    });
  }, []);

  const handleLogout = () => {
    const client = getAxiosClient();
    client.post("/auth/logout").then(() => {
      navigate("/login");
    });
  };
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
                PrintingHouseManager
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
              to="/rodzaje-projektow"
              underline="none"
              color="inherit"
            >
              Rodzaje projektów
            </Link>
            <Link
              component={RouterLink}
              to="/projekty-klientow"
              underline="none"
              color="inherit"
            >
              Projekty klientów
            </Link>
            <Link
              component={RouterLink}
              to="/users"
              underline="none"
              color="inherit"
            >
              Administratorzy
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
                onClick={handleLogout}
                sx={{ fontWeight: "bold", color: "red" }}
              >
                Wyloguj
              </MenuItem>
            </Menu>
          </Box>
        </Toolbar>
      </AppBar>

      <Box sx={styles.outletWrapper}>
        <Box sx={styles.el}>
          <Outlet />
        </Box>
      </Box>
    </Box>
  );
};
export default AuthorizedMenuLayout;
