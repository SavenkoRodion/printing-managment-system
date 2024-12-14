import {
  Button,
  Dialog,
  DialogContent,
  DialogTitle,
  TextField,
} from "@mui/material";
import styles from "./EditProjectTypeDialog.style";

type EditProjectTypeDialogProps = {
  isOpen: boolean;
  handleClose: () => void;
  handleEdit: () => void;
  projectTypeName: string;
  setProjectTypeName: (projectTypeName: string) => void;
};

const EditProjectTypeDialog = ({
  isOpen,
  handleClose,
  handleEdit,
  projectTypeName,
  setProjectTypeName,
}: EditProjectTypeDialogProps) => {
  return (
    <Dialog
      open={isOpen}
      onClose={handleClose}
      maxWidth="xs"
      fullWidth
      closeAfterTransition={false}
    >
      <DialogTitle>Edycja rodzaju projektu</DialogTitle>
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
          onClick={handleEdit}
        >
          Edytuj
        </Button>
      </DialogContent>
    </Dialog>
  );
};

export default EditProjectTypeDialog;
