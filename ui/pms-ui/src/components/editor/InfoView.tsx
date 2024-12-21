import { useEffect, useState } from "react";
import {
  FormControl,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
  Box,
  CircularProgress,
} from "@mui/material";
import getAxiosClient from "../../utility/getAxiosClient";
import Client from "../../model/Client";
import { useParams } from "react-router-dom";
import { EditorParams } from "./Editor";
import TemplateOrProject from "../../model/TemplateOrProject";
import { Controller, SubmitHandler, useForm } from "react-hook-form";
import ProjectType from "../../model/ProjectType";
import { isStatusCodeSuccessfull } from "../../utility/util";
import { useErrorSnackbar } from "../../hooks/UseErrorSnackbar";

const InfoView = () => {
  const { projectId, type } = useParams<EditorParams>();

  const [clientList, setClientList] = useState<Client[]>([]);
  const [projectTypeList, setProjectTypeList] = useState<ProjectType[]>([]);
  const [isLoading, setIsLoading] = useState<boolean>(false);

  const { showMessage } = useErrorSnackbar();

  useEffect(() => {
    const axiosClient = getAxiosClient();

    axiosClient
      .get<Client[]>("client")
      .then((e) => {
        if (isStatusCodeSuccessfull(e.status)) {
          setClientList(e.data);
        } else {
          console.error("Błąd przy pobraniu listy użytkowników");
        }
      })
      .catch(() => showMessage("Błąd przy pobraniu listy użytkowników"));

    axiosClient
      .get<ProjectType[]>("projectType")
      .then((e) => {
        if (isStatusCodeSuccessfull(e.status)) {
          setProjectTypeList(e.data);
        } else {
          showMessage("Błąd przy pobraniu listy rodzajów projektów");
        }
      })
      .catch(() => showMessage("Błąd przy pobraniu listy rodzajów projektów"));
  }, [showMessage]);

  const { handleSubmit, control, reset } = useForm<TemplateOrProject>();

  useEffect(() => {
    setIsLoading(true);

    const axiosClient = getAxiosClient();

    switch (type) {
      case "project":
        axiosClient
          .get<TemplateOrProject>(`project/${projectId}`)
          .then((e) => {
            if (isStatusCodeSuccessfull(e.status)) {
              reset(e.data);
              setIsLoading(false);
            } else {
              showMessage("Błąd przy pobraniu danych projektu");
            }
          })
          .catch(() => showMessage("Błąd przy pobraniu danych projektu"));
        break;
      case "template":
        axiosClient
          .get<TemplateOrProject>(`template/${projectId}`)
          .then((e) => {
            if (isStatusCodeSuccessfull(e.status)) {
              reset(e.data);
              setIsLoading(false);
            } else {
              showMessage("Błąd przy pobraniu danych szablonu");
            }
          })
          .catch(() => showMessage("Błąd przy pobraniu danych szablonu"));
        break;
    }
  }, [reset, projectId, type, showMessage]);

  const onSubmit: SubmitHandler<TemplateOrProject> = (data) => {
    const axiosClient = getAxiosClient();
    switch (type) {
      case "project":
        axiosClient
          .put("project/edit", {
            projectId: data.id,
            newProjectName: data.name,
            newClientId: data.clientId,
            newProjectTypeId: data.projectTypeId,
            newFormat: data.format,
          })
          .then(() => window.location.reload())
          .catch(() => showMessage("Nie udało się zedytować projekt"));

        break;
      case "template":
        axiosClient
          .put("template/edit", {
            templateId: data.id,
            newTemplateName: data.name,
            newClientId: data.clientId,
            newProjectTypeId: data.projectTypeId,
            newFormat: data.format,
          })
          .then(() => window.location.reload())
          .catch(() => showMessage("Nie udało się zedytować szablon"));
        break;
    }
  };

  return (
    <Box>
      {!isLoading ? (
        <form onSubmit={handleSubmit(onSubmit)}>
          <FormControl fullWidth margin="normal">
            <Controller
              control={control}
              name="name"
              render={({ field: { value, onChange } }) => (
                <TextField label="Nazwa" value={value} onChange={onChange} />
              )}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <InputLabel id="demo-simple-select-label">Klient</InputLabel>
            <Controller
              control={control}
              name={"clientId"}
              render={({ field: { value, onChange } }) => {
                return (
                  <>
                    {value && clientList.length ? (
                      <Select
                        label="Klient"
                        labelId="demo-simple-select-label"
                        value={value}
                        onChange={onChange}
                      >
                        {clientList.map((e) => (
                          <MenuItem value={e.uuid} key={e.uuid}>
                            {e.name}
                          </MenuItem>
                        ))}
                      </Select>
                    ) : (
                      <></>
                    )}
                  </>
                );
              }}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <InputLabel id="projectType-type-label">Rodzaj Projektu</InputLabel>
            <Controller
              control={control}
              name={"projectTypeId"}
              render={({ field: { value, onChange } }) => {
                return (
                  <>
                    {value && projectTypeList.length ? (
                      <Select
                        labelId="projectType-type-label"
                        value={value}
                        onChange={onChange}
                        label={"Rodzaj Projektu"}
                      >
                        {projectTypeList.map((e) => (
                          <MenuItem value={e.id} key={e.id}>
                            {e.name}
                          </MenuItem>
                        ))}
                      </Select>
                    ) : (
                      <></>
                    )}
                  </>
                );
              }}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <Controller
              control={control}
              name="format"
              render={({ field: { value, onChange } }) => (
                <TextField label="Format" value={value} onChange={onChange} />
              )}
            />
          </FormControl>
          <Box mt={2}>
            <Button variant="contained" type="submit">
              Zapisz
            </Button>
          </Box>
        </form>
      ) : (
        <CircularProgress />
      )}
    </Box>
  );
};

export default InfoView;
