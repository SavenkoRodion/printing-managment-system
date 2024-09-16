import { Dialog, DialogContent, Typography } from "@mui/material";

type CreateProductModalProps = {
  isOpen: boolean;
  handleClose: () => void;
};

const CreateProductModal = ({
  isOpen,
  handleClose,
}: CreateProductModalProps) => {
  return (
    <Dialog open={isOpen} onClose={handleClose}>
      <DialogContent>
        <Typography>lolek</Typography>
      </DialogContent>
    </Dialog>
  );
};

export default CreateProductModal;
