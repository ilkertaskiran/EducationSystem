import React, { Component } from 'react';

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
        return (
            <div>
                <h1 id="tabelLabel" >Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {educations}
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : EducationDataFetch.renderEducationsTable(this.state.educations);

        return (
            <div>
                <h1 id="tabelLabel" >Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateWeatherData() {
        const response = await fetch('education');
        const data = await response.json();
        this.setState({ educations: data, loading: false });
    }
}
