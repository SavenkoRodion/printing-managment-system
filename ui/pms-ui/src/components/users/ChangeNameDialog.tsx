import {
    Box,
    Button,
    Dialog,
    DialogContent,
    DialogTitle,
    TextField,
  } from "@mui/material";
  import getAxiosClient from "../../utility/getAxiosClient";
  import { useState } from "react";
  import { isStatusCodeSuccessfull } from "../../utility/util";
  
  type ChangeNameDialogProps = {
    isOpen: boolean;
    onClose: () => void;
    userEmail: string;
    userId: string;
    currentName: string; 
  };
  
  const ChangeNameDialog = ({
    isOpen,
    onClose,
    userEmail,
    userId,
    currentName,
  }: ChangeNameDialogProps) => {
    const client = getAxiosClient();
  
    const [newName, setNewName] = useState(currentName);
  
    const handleNameChange = () => {
      client
        .put("admin/change-name", {
          UserId: userId,
          NewName: newName,
        })
        .then((res) => {
          if (!isStatusCodeSuccessfull(res.status)) {
            alert("Nie udało się zmienić imienia");
          }
          window.location.reload(); 
        });
    };
  
    return (
      <Dialog open={isOpen} onClose={onClose} maxWidth="xs" fullWidth>
        <DialogTitle>Wprowadź nowe imię dla użytkownika {userEmail}</DialogTitle>
        <DialogContent>
          <Box
            sx={{
              padding: "8px 0",
              gap: "8px",
              display: "flex",
              flexDirection: "column",
            }}
          >
            <TextField
              size="small"
              label="Nowe imię"
              fullWidth
              value={newName}
              onChange={(e) => setNewName(e.target.value)}
            />
            <Button
              variant="contained"
              fullWidth
              onClick={handleNameChange}
            >
              Zmień imię
            </Button>
          </Box>
        </DialogContent>
      </Dialog>
    );
  };
  
  export default ChangeNameDialog;
  