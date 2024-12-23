import { Box } from "@mui/material";
import ProjectTypeList from "./ProjectTypeList";
import getAxiosClient from "../../utility/getAxiosClient";
import { useEffect, useState } from "react";
import ProjectType from "../../model/ProjectType";
import CreateProjectTypeDialog from "./Dialogs/CreateProjectTypeDialog/CreateProjectTypeDialog";
import DeleteProjectTypeDialog from "./Dialogs/DeleteProjectTypeDialog/DeleteProjectTypeDialog";
import EditProjectTypeDialog from "./Dialogs/EditProjectTypeDialog/EditProjectTypeDialog";
import PageHeader from "../reusable/PageHeader";
import { isStatusCodeSuccessfull } from "../../utility/util";

const ProjectTypePage = () => {
  const client = getAxiosClient();

  const [projectTypes, setProjectTypes] = useState<ProjectType[]>([]);
  const [isCreateModalOpen, setIsCreateModalOpen] = useState(false);
  const [isDeleteDialogOpen, setIsDeleteDialogOpen] = useState(false);
  const [isEditDialogOpen, setIsEditDialogOpen] = useState(false);

  const [deleteDialogProjectTypeName, setDeleteDialogProjectTypeName] =
    useState<string>("");
  const [deleteDialogProjectTypeId, setDeleteDialogProjectTypeId] = useState<
    number | undefined
  >(undefined);

  const [editDialogProjectTypeId, setEditDialogProjectTypeId] = useState<
    number | undefined
  >(undefined);
  const [editDialogProjectTypeName, setEditDialogProjectTypeName] =
    useState("");

  const handleDeleteDialogOpen = (
    projectTypeId: number,
    projectTypeName: string
  ) => {
    setDeleteDialogProjectTypeId(projectTypeId);
    setDeleteDialogProjectTypeName(projectTypeName);
    setIsDeleteDialogOpen(true);
  };

  const handleEditDialogOpen = (
    projectTypeId: number,
    projectTypeName: string
  ) => {
    setEditDialogProjectTypeId(projectTypeId);
    setEditDialogProjectTypeName(projectTypeName);
    setIsEditDialogOpen(true);
  };

  const handleDelete = () => {
    client
      .delete<boolean>(`projectType/${deleteDialogProjectTypeId}`)
      .then((res) => {
        if (!isStatusCodeSuccessfull(res.status)) {
          console.error("Nie udało się usunąć projectType");
        }
        window.location.reload();
      });
  };

  const handleUpdate = () => {
    client
      .put<boolean>("projectType/rename", {
        Id: editDialogProjectTypeId,
        Name: editDialogProjectTypeName,
      })
      .then((res) => {
        if (!isStatusCodeSuccessfull(res.status)) {
          console.error("Nie udało się zmienić nazwy rodzaju projektu");
        }
        window.location.reload();
      });
  };

  useEffect(() => {
    client
      .get<ProjectType[]>("projectType")
      .then((res) => setProjectTypes(res.data));
  }, []);

  return (
    <Box>
      <PageHeader
        pageTitle="Lista rodzajów projektów"
        handleCreate={() => setIsCreateModalOpen(true)}
        createButtonText="Dodaj nowy rodzaj"
      />
      <ProjectTypeList
        rows={projectTypes}
        handleDeleteDialogOpen={handleDeleteDialogOpen}
        handleEditDialogOpen={handleEditDialogOpen}
      />

      <CreateProjectTypeDialog
        isOpen={isCreateModalOpen}
        handleClose={() => setIsCreateModalOpen(false)}
      ></CreateProjectTypeDialog>
      <DeleteProjectTypeDialog
        isOpen={isDeleteDialogOpen}
        handleClose={() => setIsDeleteDialogOpen(false)}
        projectTypeName={deleteDialogProjectTypeName}
        handleDelete={handleDelete}
      ></DeleteProjectTypeDialog>
      <EditProjectTypeDialog
        isOpen={isEditDialogOpen}
        handleClose={() => setIsEditDialogOpen(false)}
        handleEdit={handleUpdate}
        projectTypeName={editDialogProjectTypeName}
        setProjectTypeName={setEditDialogProjectTypeName}
      ></EditProjectTypeDialog>
    </Box>
  );
};

export default ProjectTypePage;
