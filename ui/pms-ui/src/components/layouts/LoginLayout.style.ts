import { SxProps } from "@mui/material";

const wrapper: SxProps = {
  padding: "45px 15px 0",
  display: "flex",
  justifyContent: "center",
  flexDirection: "column",
  marginBottom: "30px",
  gap: "15px",
};

const headerTextLine1: SxProps = {
  fontSize: "24px",
  fontWeight: "100",
  margin: "0 auto",
};
const headerTextLine2: SxProps = {
  fontSize: "21px",
  fontWeight: "300",
  margin: "0 auto",
};

const loginImage: SxProps = {
  height: "84px",
  width: "92px",
  margin: "0 auto",
  marginTop: "10px",
};

const styles = { wrapper, headerTextLine1, headerTextLine2, loginImage };

export default styles;
