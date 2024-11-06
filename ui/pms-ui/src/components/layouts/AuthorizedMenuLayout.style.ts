import { SxProps } from "@mui/material";

const outletWrapper: SxProps = {
  width: "100%",
  maxWidth: "1300px",
  paddingTop: "100px",
};

const el: SxProps = {
  display: "flex",
  flexDirection: "column",
  alignItems: "stretch",
  gap: 2,
  padding: 2,
  border: "1px solid grey",
  borderRadius: 1,
  boxShadow: 1,
  paddingBottom: "20px",
};

const styles = { outletWrapper, el };

export default styles;
