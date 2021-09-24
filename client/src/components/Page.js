import React from 'react';
import PropTypes from 'prop-types';

function Page(props) {
  return (
    <React.Fragment>
    <img src="{props.pageId}.PNG" alt="door {props.pageId}"/>
    <h6>{props.text}</h6>

    </React.Fragment>
  )
}

Page.propTypes = {
  pageId: PropTypes.string.isRequired,
  text: PropTypes.string.isRequired
}

export default Page;
//unsure how I'll need to do this with images...