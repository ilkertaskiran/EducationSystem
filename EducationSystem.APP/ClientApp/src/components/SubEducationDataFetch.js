import React, { Component } from 'react';

export class SubEducationDataFetch extends Component {
    static displayName = SubEducationDataFetch.name;

    constructor(props) {
        super(props);
        this.state = { subEducations: [], loading: true };
    }

    componentDidMount() {
        this.getSubEducations();
    }


    static renderSubEducationsTable(subEducations) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Url</th>
                        <th>Created Time</th>
                        <th>Updated Time</th>
                    </tr>
                </thead>
                <tbody>
                    {subEducations.map(subEducation =>
                        <tr key={subEducation.id}>
                            <td>{subEducation.id}</td>
                            <td>{subEducation.name}</td>
                            <td>{subEducation.description}</td>
                            <td>{subEducation.url}</td>
                            <td>{subEducation.createdTime}</td>
                            <td>{subEducation.updatedTime}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : SubEducationDataFetch.renderSubEducationsTable(this.state.subEducations);

        return (
            <div>
                <h1 id="tabelLabel">Sub Educations</h1>
                {contents}
            </div>
        );
    }

    async getSubEducations() {
        console.log("getSubEducations start of func");
        const response = await fetch('subEducation/get-sub-educations-by-id');
        const data = await response.json();
        console.log("data", data);
        this.setState({ subEducations: data, loading: false });
    }
}
