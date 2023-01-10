import React, { Component } from 'react';
import { Link } from "react-router-dom";

export class EducationDataFetch extends Component {
    static displayName = EducationDataFetch.name;

    constructor(props) {
        super(props);
        this.state = { educations: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }


    static renderEducationsTable(educations) {

        function handleRowClick(id, isPublished) {
            if (!isPublished)
                alert("This education has not published.");
            else
                window.location.href = "/get-sub-educations-by-id?id=" + id;
        }


        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Publish Status</th>
                        <th>Start Date</th>
                        <th>End Date</th>
                        <th>Created Time</th>
                        <th>Updated Time</th>
                        {/*<th></th>*/}
                    </tr>
                </thead>
                <tbody>
                    {educations.map(education =>
                        <tr key={education.id} onClick={() => handleRowClick(education.id, education.isPublished)}>
                            <td>{education.id}</td>
                            <td>{education.name}</td>
                            <td>{education.isPublished ? "Published" : "-"}</td>
                            <td>{education.startDate}</td>
                            <td>{education.endDate}</td>
                            <td>{education.createdTime}</td>
                            <td>{education.updatedTime}</td>
                            {/*<td>{!education.isPublished ? <Link to="/signup" className="btn btn-danger">Publish</Link> : ""}</td>*/}
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : EducationDataFetch.renderEducationsTable(this.state.educations);

        return (
            <div>
                <h1 id="tabelLabel" >Educations</h1>
                <Link to="/add-education" className="btn btn-warning" id="addButton">Add Education</Link>
                {contents}
            </div>
        );
    }

    async populateWeatherData() {
        const response = await fetch('education/get-educations');
        const data = await response.json();

        this.setState({ educations: data, loading: false });
    }
}
