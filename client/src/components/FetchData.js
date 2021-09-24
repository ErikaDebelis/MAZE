import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { pages: [], loading: true };
  }

  componentDidMount() {
    this.populatePage();
  }

  static renderPages(pages) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Page #</th>
            <th>text</th>
          </tr>
        </thead>
        <tbody>
          {pages.map(page =>
            <tr key={page.pageId}>
              <td>{page.text}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderPages(this.state.pages);

    return (
      <div>
        <h1 id="tabelLabel" >page</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('page');
    const data = await response.json();
    this.setState({ pages: data, loading: false });
  }
}
