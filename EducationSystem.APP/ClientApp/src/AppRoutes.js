import { EducationDataFetch } from "./components/EducationDataFetch";
import { SubEducationDataFetch } from "./components/SubEducationDataFetch";

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
    }
];

export default AppRoutes;
