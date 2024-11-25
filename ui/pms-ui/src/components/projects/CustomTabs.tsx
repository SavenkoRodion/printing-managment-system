import { Tabs, Tab, Box, Button } from "@mui/material";
import { a11yProps } from "./utils";

interface CustomTabsProps {
  currentTab: number;
  onTabChange: (newValue: number) => void;
}

const CustomTabs = ({ currentTab, onTabChange }: CustomTabsProps) => (
  <Tabs
    value={currentTab}
    onChange={(e, newValue) => onTabChange(newValue)}
    aria-label="basic tabs example"
  >
    <Tab label="Szablony firmowe" {...a11yProps(0)} />
    <Tab label="Projekty zapisane" {...a11yProps(1)} />
  </Tabs>
);

export default CustomTabs;
