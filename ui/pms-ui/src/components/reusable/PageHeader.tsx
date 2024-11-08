import { Box, Button, Typography } from "@mui/material";

type PageHeaderProps = {
  pageTitle: string;
  createButtonText: string;
  handleCreate: () => void;
};

const PageHeader = ({
  pageTitle,
  createButtonText,
  handleCreate,
}: PageHeaderProps) => {
  return (
    <Box
      sx={{
        display: "flex",
        justifyContent: "space-between",
        alignItems: "center",
        paddingBottom: "16px",
        borderBottom: "1px solid grey",
      }}
    >
      <Typography variant="h6">{pageTitle}</Typography>
      <Button variant={"contained"} onClick={handleCreate}>
        {createButtonText}
      </Button>
    </Box>
  );
};

export default PageHeader;
