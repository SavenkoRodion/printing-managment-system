import React, { useEffect, useState } from "react";
import { Container, Box, ToggleButton, ToggleButtonGroup } from "@mui/material";
import EditorView from "./EditorView";
import EditorTab from "./EditorTab";
import ProjectOrTemplate from "../../model/TemplateOrProject";
import InfoView from "./InfoView";

export type EditorParams = { projectId: string; type: "template" | "project" };

const Editor = () => {
  const [view, setView] = useState<EditorTab>(EditorTab.Info);

  const handleViewChange = (
    _event: React.MouseEvent<HTMLElement>,
    newTab: EditorTab
  ) => {
    if (newTab !== null) {
      setView(newTab);
    }
  };

  // useEffect(() => {
  //   client
  //     .get<ProjectOrTemplate>(
  //       `${type === "template" ? "template" : "project"}/${projectId}`
  //     )
  //     .then((e) => console.log(e));
  // }, []);

  return (
    <Container>
      <Box display="flex" justifyContent="center" mb={2}>
        <ToggleButtonGroup
          value={view}
          exclusive
          onChange={handleViewChange}
          aria-label="view selection"
        >
          <ToggleButton value={EditorTab.Info} aria-label="info view">
            Info
          </ToggleButton>
          <ToggleButton value={EditorTab.Editor} aria-label="editor view">
            Edytor
          </ToggleButton>
        </ToggleButtonGroup>
      </Box>
      {view === EditorTab.Info && <InfoView />}
      {view === EditorTab.Editor && <EditorView />}
    </Container>
  );
};

export default Editor;
