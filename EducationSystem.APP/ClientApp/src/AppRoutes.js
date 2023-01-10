import { EducationDataFetch } from "./components/EducationDataFetch";
import { SubEducationDataFetch } from "./components/SubEducationDataFetch";
import { AddEducationDataFetch } from "./components/AddEducationDataFetch";

const AppRoutes = [
    {
        index: true,
        path: '/',
        element: <EducationDataFetch />
    },
    {
        path: '/get-educations',
        element: <EducationDataFetch />
    },
    {
        path: '/get-sub-educations-by-id',
        element: <SubEducationDataFetch />
    },
    {
        path: '/add-education',
        element: <AddEducationDataFetch />
    }
];

export default AppRoutes;
