<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/ArrayOfOrder">
		<html>
			<head>
				<title>Orders</title>
			</head>
			<body>
				<ul>
					<xsl:for-each select="Order">
						<li>
							<xsl:value-of select="Id" />
						</li>
            <ul>
              <xsl:for-each select="Details/OrderDetail">
                <li>
                  <xsl:value-of select="Id" />
                </li>
              </xsl:for-each>
            </ul>
					</xsl:for-each>
				</ul>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
