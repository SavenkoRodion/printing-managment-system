import { Box } from "@mui/material";
import ClientList from "./ClientsList";
import getAxiosClient from "../../utility/getAxiosClient";
import { useCallback, useEffect, useState } from "react";
import Client from "../../model/Client";
import CreateClientDialog from "./Dialogs/CreateClientDialog/CreateClientDialog";
import DeleteClientDialog from "./Dialogs/DeleteClientDialog/DeleteClientDialog";
import EditClientDialog from "./Dialogs/EditClientDialog/EditClientDialog";
import PageHeader from "../reusable/PageHeader";
import { isStatusCodeSuccessfull, sortClientsByName } from "../../utility/util";

const ClientPage = () => {
  const client = getAxiosClient();

  const [clients, setClients] = useState<Client[]>([]);
  const [isCreateModalOpen, setIsCreateModalOpen] = useState(false);
  const [isDeleteDialogOpen, setIsDeleteDialogOpen] = useState(false);
  const [isEditDialogOpen, setIsEditDialogOpen] = useState(false);
  const [selectedClient, setSelectedClient] = useState<Client>({} as Client);

  const handleDeleteDialogOpen = (client: Client) => {
    setSelectedClient(client);
    setIsDeleteDialogOpen(true);
  };

  const handleEditDialogOpen = (client: Client) => {
    setSelectedClient(client);
    setIsEditDialogOpen(true);
  };

  const fetchClients = useCallback(() => {
    client.get<Client[]>("client").then((res) => {
      if (isStatusCodeSuccessfull(res.status)) {
        setClients(sortClientsByName(res.data));
      } else {
        console.error("Failed to fetch clients");
      }
    });
  }, [client]);

  useEffect(() => {
    fetchClients();
  }, []);

  const handleDelete = (clientId: string) => {
    client.delete<boolean>(`client/${clientId}`).then((res) => {
      if (isStatusCodeSuccessfull(res.status)) {
        fetchClients();
      } else {
        console.error("Failed to delete client");
      }
    });
  };

  const handleUpdate = (updatedClient: Client) => {
    if (
      updatedClient?.uuid &&
      updatedClient?.name &&
      updatedClient?.email &&
      updatedClient?.address
    ) {
      client
        .put<boolean>("client/edit", {
          Uuid: updatedClient.uuid,
          Name: updatedClient.name,
          Email: updatedClient.email,
          Address: updatedClient.address,
        })
        .then((res) => {
          if (isStatusCodeSuccessfull(res.status)) {
            fetchClients();
          } else {
            console.error("Failed to update client");
          }
        });
    }
  };

  return (
    <Box>
      <PageHeader
        pageTitle="Lista klientów"
        handleCreate={() => setIsCreateModalOpen(true)}
        createButtonText="Dodaj nowego klienta"
      />
      <ClientList
        rows={clients}
        handleDeleteDialogOpen={handleDeleteDialogOpen}
        handleEditDialogOpen={handleEditDialogOpen}
      />

      <CreateClientDialog
        isOpen={isCreateModalOpen}
        handleClose={() => setIsCreateModalOpen(false)}
        handleCreate={fetchClients}
      ></CreateClientDialog>
      <DeleteClientDialog
        isOpen={isDeleteDialogOpen}
        handleClose={() => setIsDeleteDialogOpen(false)}
        client={selectedClient}
        handleDelete={handleDelete}
      ></DeleteClientDialog>
      <EditClientDialog
        isOpen={isEditDialogOpen}
        handleClose={() => setIsEditDialogOpen(false)}
        handleEdit={handleUpdate}
        client={selectedClient}
      ></EditClientDialog>
    </Box>
  );
};

export default ClientPage;
