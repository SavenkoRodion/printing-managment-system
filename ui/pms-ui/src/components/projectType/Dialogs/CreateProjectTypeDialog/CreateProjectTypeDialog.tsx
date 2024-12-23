import {
  Button,
  Dialog,
  DialogContent,
  DialogTitle,
  TextField,
} from "@mui/material";
import styles from "./CreateProjectTypeDialog.style";
import { useState } from "react";
import getAxiosClient from "../../../../utility/getAxiosClient";

type CreateProjectTypeModalProps = {
  isOpen: boolean;
  handleClose: () => void;
};

const CreateProjectTypeDialog = ({
  isOpen,
  handleClose,
}: CreateProjectTypeModalProps) => {
  const [projectTypeName, setProjectTypeName] = useState("");

  const client = getAxiosClient();

  const createProjectType = () => {
    client
      .post<boolean>("projectType", { ProjectTypeName: projectTypeName })
      .then(() => window.location.reload());
  };

  return (
    <Dialog
      open={isOpen}
      onClose={handleClose}
      maxWidth="xs"
      fullWidth
      closeAfterTransition={false}
    >
      <DialogTitle>Stwórz nowy rodzaj projektu</DialogTitle>
      <DialogContent sx={styles.dialogContent}>
        <TextField
          size="small"
          label="Nazwa rodzaju projektu"
          sx={styles.dialogElement}
          value={projectTypeName}
          onChange={(e) => setProjectTypeName(e.target.value)}
        />
        <Button
          variant="contained"
          sx={styles.dialogElement}
          onClick={createProjectType}
        >
          Stwórz
        </Button>
      </DialogContent>
    </Dialog>
  );
};

export default CreateProjectTypeDialog;
