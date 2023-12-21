<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- <xsl:strip-space elements="*"/> -->
    <xsl:template match="CollectionOfPoems">
        <html>
            <body>
                <xsl:apply-templates/>
            </body>
        </html>
    </xsl:template>
    <xsl:template match="Poem">
            <Publicación>
              <xsl:attribute name="year">
                <xsl:value-of select="@YearOfPublication"/>
              </xsl:attribute>
            </Publicación>
            <xsl:apply-templates/>
          </xsl:template>
    <xsl:template match="Author">
        <br/>
        <h4>
            <xsl:apply-templates/>
        </h4>
    </xsl:template>
    <xsl:template match="FirstName">
        <strong><xsl:apply-templates/></strong>
    </xsl:template>
    <xsl:template match="LastName">
        <xsl:apply-templates/>
    </xsl:template>
    <xsl:template match="Title">
        <h2>
            <xsl:apply-templates/>
        </h2>
    </xsl:template>
    <xsl:template match="Subtitle">
        <h4>
            <xsl:apply-templates/>
        </h4>
    </xsl:template>
    <xsl:template match="Strophe">
        <p>
            <xsl:apply-templates/>
        </p>
    </xsl:template>
    <xsl:template match="Verse">
        <xsl:apply-templates/><br/>
    </xsl:template>
</xsl:stylesheet>